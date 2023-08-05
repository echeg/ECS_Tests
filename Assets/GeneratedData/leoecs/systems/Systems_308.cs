using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System308 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component120,Component312,Component454,Component167> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component129>())
   {
    q+=1;
    var com = entity.Get<Component129>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component223>())
   {
    q+=1;
    var com = entity.Get<Component223>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component177>())
   {
    q+=1;
    var com = entity.Get<Component177>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component18>())
   {
    q+=1;
    var com = entity.Get<Component18>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
