using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System28 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component499>().Inc<Component99>().Inc<Component385>().Inc<Component110>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component65>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component65>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component305>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component305>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component463>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component463>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component406>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component406>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
