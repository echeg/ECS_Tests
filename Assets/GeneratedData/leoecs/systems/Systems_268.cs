using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System268 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component178,Component410> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component343>())
   {
    q+=1;
    var com = entity.Get<Component343>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component135>())
   {
    q+=1;
    var com = entity.Get<Component135>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component150>())
   {
    q+=1;
    var com = entity.Get<Component150>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component47>())
   {
    q+=1;
    var com = entity.Get<Component47>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
