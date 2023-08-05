using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System317 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component326,Component400,Component432> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component288>())
   {
    q+=1;
    var com = entity.Get<Component288>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component243>())
   {
    q+=1;
    var com = entity.Get<Component243>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component162>())
   {
    q+=1;
    var com = entity.Get<Component162>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component60>())
   {
    q+=1;
    var com = entity.Get<Component60>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
