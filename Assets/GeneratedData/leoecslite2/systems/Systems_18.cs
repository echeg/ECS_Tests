using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System18 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component50>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component243>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component243>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component442>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component442>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component415>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component415>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component186>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component186>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
