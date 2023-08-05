using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System275 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component181> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component61>())
   {
    q+=1;
    var com = entity.Get<Component61>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component115>())
   {
    q+=1;
    var com = entity.Get<Component115>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component215>())
   {
    q+=1;
    var com = entity.Get<Component215>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component116>())
   {
    q+=1;
    var com = entity.Get<Component116>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
