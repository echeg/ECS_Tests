using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System213 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component471,Component389,Component252,Component470> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component39>())
   {
    q+=1;
    var com = entity.Get<Component39>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component383>())
   {
    q+=1;
    var com = entity.Get<Component383>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component167>())
   {
    q+=1;
    var com = entity.Get<Component167>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component353>())
   {
    q+=1;
    var com = entity.Get<Component353>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
