using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System98 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component260,Component206,Component107> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component242>())
   {
    q+=1;
    var com = entity.Get<Component242>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component240>())
   {
    q+=1;
    var com = entity.Get<Component240>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component74>())
   {
    q+=1;
    var com = entity.Get<Component74>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component12>())
   {
    q+=1;
    var com = entity.Get<Component12>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
