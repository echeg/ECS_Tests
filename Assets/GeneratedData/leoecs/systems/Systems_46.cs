using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System46 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component206,Component255,Component189,Component379> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component238>())
   {
    q+=1;
    var com = entity.Get<Component238>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component458>())
   {
    q+=1;
    var com = entity.Get<Component458>();
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
   if (entity.Has<Component428>())
   {
    q+=1;
    var com = entity.Get<Component428>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
