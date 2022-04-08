using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System50 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component422,Component444,Component361> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component11>())
   {
    q+=1;
    var com = entity.Get<Component11>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component46>())
   {
    q+=1;
    var com = entity.Get<Component46>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component340>())
   {
    q+=1;
    var com = entity.Get<Component340>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component398>())
   {
    q+=1;
    var com = entity.Get<Component398>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
