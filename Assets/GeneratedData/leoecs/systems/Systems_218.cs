using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System218 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component475> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component305>())
   {
    q+=1;
    var com = entity.Get<Component305>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component83>())
   {
    q+=1;
    var com = entity.Get<Component83>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component247>())
   {
    q+=1;
    var com = entity.Get<Component247>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component425>())
   {
    q+=1;
    var com = entity.Get<Component425>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
