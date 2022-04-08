using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System12 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component179,Component454> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component172>())
   {
    q+=1;
    var com = entity.Get<Component172>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component79>())
   {
    q+=1;
    var com = entity.Get<Component79>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component80>())
   {
    q+=1;
    var com = entity.Get<Component80>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component424>())
   {
    q+=1;
    var com = entity.Get<Component424>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
